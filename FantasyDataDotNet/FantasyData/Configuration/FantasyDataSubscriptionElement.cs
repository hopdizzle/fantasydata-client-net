﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FantasyData.Configuration
{
  public class FantasyDataSubscriptionElement : ConfigurationElement
  {
    [ConfigurationProperty("name", IsRequired = true, IsKey = true)]
    public string Name
    {
      get
      {
        return (string)this["name"];
      }
      set
      {
        this["name"] = value;
      }
    }

    [ConfigurationProperty("baseUrl", IsRequired = true, DefaultValue = "http://api.nfldata.apiphany.com/developer/")]
    public Uri ApiBaseUrl
    {
      get
      {
        return (Uri)this["baseUrl"];
      }
      set
      {
        this["baseUrl"] = value;
      }
    }

    [ConfigurationProperty("primarySubscriptionKey", IsRequired = true, DefaultValue ="NotSet")]
    public string PrimarySubscriptionKey
    {
      get
      {
        return (string)this["primarySubscriptionKey"];
      }
      set
      {
        this["primarySubscriptionKey"] = value;
      }
    }

    [ConfigurationProperty("secondarySubscriptionKey", IsRequired = false, DefaultValue = "NotSet")]
    public string SecondarySubscriptionKey
    {
      get
      {
        return (string)this["secondarySubscriptionKey"];
      }
      set
      {
        this["secondarySubscriptionKey"] = value;
      }
    }
  }
}
