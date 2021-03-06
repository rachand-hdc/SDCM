﻿/*++
    Copyright (c) Microsoft Corporation. All rights reserved.

    Licensed under the MIT license.  See LICENSE file in the project root for full license information.  
--*/
using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace SurfaceDevCenterManager.DevCenterApi
{
    public class Audience : IArtifact
    {
        [JsonProperty("id")]
        public string Id { get; set; }

        [JsonProperty("name")]
        public string Name { get; set; }

        [JsonProperty("description")]
        public string Description { get; set; }

        [JsonProperty("audienceName")]
        public string AudienceName { get; set; }

        [JsonProperty("links")]
        public List<Link> Links { get; set; }

        public void Dump()
        {
            Console.WriteLine("---- Audience: " + Id);
            Console.WriteLine("         audienceName: " + AudienceName);
            Console.WriteLine("         description:  " + Description);
            Console.WriteLine("         name:        " + Name);
            Console.WriteLine("         Links:");
            if (Links != null)
            {
                foreach (Link link in Links)
                {
                    link.Dump();
                }
            }
        }
    }

}
