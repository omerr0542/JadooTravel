﻿namespace JadooTravel.Settings;

public class DatabaseSettings : IDatabaseSettings
{
    public string CollectionString { get; set; }
    public string DatabaseName { get; set; }
    public string CategoryCollectionName { get; set; }
    public string DestinationCollectionName { get; set; }
    public string FeatureCollectionName { get; set; }
    public string TripPlanCollectionName { get; set; }
}
