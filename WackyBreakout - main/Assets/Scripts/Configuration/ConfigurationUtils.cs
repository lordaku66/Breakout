using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    #region Properties
    
    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return ConfigData.PaddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public static float BallImpulsiveForce
    {
        get { return ConfigData.BallImpulseForce; }
    }

    // <summary>
    /// Gets the Lifetime of the ball in the game
    /// </summary>
    /// <value>ball lifetime</value>
    public static float BallLifetime
    {
        get { return ConfigData.BallLifetime; }
    }

    /// <summary>
    /// Gets the min spawn time limit of the balls
    /// </summary>
    public static float minSpawnTime
    {
        get { return ConfigData.minSpawnTime; }
    }

    /// <summary>
    /// Gets the max spawn time limit of the balls
    /// </summary>
    public static float maxSpawnTime
    {
        get { return ConfigData.maxSpawnTime; }
    }

    /// <summary>
    /// Gets the number of points a standard block is worth
    /// </summary>
    /// <value>standard block points</value>
    public static int StandardBlockPoints
    {
        get { return ConfigData.StandardBlockPoints; }
    }

    /// <summary>
    /// Gets the number of points a bonus block is worth
    /// </summary>
    /// <value>bonus block points</value>
    public static int BonusBlockPoints
    {
        get { return ConfigData.BonusBlockPoints; }
    }

    /// <summary>
    /// Gets the number of points a pickup block is worth
    /// </summary>
    /// <value>pickup block points</value>
    public static int PickupBlockPoints
    {
        get { return ConfigData.PickupBlockPoints; }
    }

    /// <summary>
    /// Gets the probability that a standard block
    /// will be added to the level
    /// </summary>
    /// <value>standard block probability</value>
    public static float StandardBlockProbability
    {
        get { return ConfigData.StandardBlockProbability; }
    }

    /// <summary>
    /// Gets the probability that a bonus block
    /// will be added to the level
    /// </summary>
    /// <value>bonus block probability</value>
    public static float BonusBlockProbability
    {
        get { return ConfigData.BonusBlockProbability; }
    }

    /// <summary>
    /// Gets the probability that a freezer block
    /// will be added to the level
    /// </summary>
    /// <value>freezer block probability</value>
    public static float FreezerBlockProbability
    {
        get { return ConfigData.FreezerBlockProbability; }
    }

    /// <summary>
    /// Gets the probability that a speedup block
    /// will be added to the level
    /// </summary>
    /// <value>speedup block probability</value>
    public static float SpeedupBlockProbability
    {
        get { return ConfigData.SpeedupBlockProbability; }
    }

    /// <summary>
    /// Gets the number of balls per game
    /// </summary>
    /// <value>balls per game</value>
    public static int BallsPerGame
    {
        get { return ConfigData.BallsPerGame; }
    }

    /// <summary>
    /// Gets the duration of the freezer effect
    /// in seconds
    /// </summary>
    /// <value>freezer seconds</value>
    public static float FreezerSeconds
    {
        get { return ConfigData.FreezerSeconds; }
    }

    /// <summary>
    /// Gets the speedup factor
    /// </summary>
    /// <value>speedup factor</value>
    public static float SpeedupFactor
    {
        get { return ConfigData.SpeedupFactor; }
    }

    /// <summary>
    /// Gets the duration of the speedup effect
    /// in seconds
    /// </summary>
    /// <value>speedup seconds</value>
    public static float SpeedupSeconds
    {
        get { return ConfigData.SpeedupSeconds; }
    }
    #endregion

    static ConfigurationData ConfigData;
    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        ConfigData = new ConfigurationData();
    }
}
