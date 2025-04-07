using System.Collections;
using System.IO;
using System;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data with default values
    static float teddyBearMoveUnitsPerSecond;
    static float cooldownSeconds;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the teddy bear move units per second
    /// </summary>
    /// <value>teddy bear move units per second</value>
    public float TeddyBearMoveUnitsPerSecond
    {
        get { return teddyBearMoveUnitsPerSecond; }
    }
        
    /// <summary>
    /// Gets the cooldown seconds for shooting
    /// </summary>
    /// <value>cooldown seconds</value>
    public float CooldownSeconds
    {
        get { return cooldownSeconds; }    
    }

    #endregion

    #region Constructor

    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        // read and save configuration data from file

        string filePath = "ConfigurationData.csv";
        string headerData;
        string valueData;
        StreamReader fileData = null;

        {
            try
            {
                // Open the file
                string fullFilePath = Path.Combine(Application.streamingAssetsPath, filePath);
                fileData = File.OpenText(fullFilePath);

                // Get the CSV data
                headerData = fileData.ReadLine();
                valueData = fileData.ReadLine();

                SetConfigurationDataFields(valueData);
            }

            catch (Exception ex)
            {
                Debug.Log(ex.ToString());
            }

            finally
            {
                if (fileData != null) fileData.Close();
            }
        }

    }


    /// <summary>
    /// Sets the configuration data fields from the provided
    /// csv string
    /// </summary>
    /// <param name="csvValues">csv string of values</param>
    static void SetConfigurationDataFields(string csvValues)
    {
        teddyBearMoveUnitsPerSecond = int.Parse(csvValues.Substring(0, csvValues.IndexOf(",")));
        cooldownSeconds = int.Parse(csvValues.Substring(csvValues.IndexOf(",") + 1));
    }

    #endregion
}
