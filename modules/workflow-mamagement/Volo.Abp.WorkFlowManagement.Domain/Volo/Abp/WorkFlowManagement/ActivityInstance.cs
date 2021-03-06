﻿using System;
using Newtonsoft.Json.Linq;
using Volo.Abp.Domain.Entities;
using Volo.Abp.Domain.Entities.Auditing;

namespace Volo.Abp.WorkFlowManagement
{
    public class ActivityInstance:AuditedEntity<string>
    {
        public ActivityInstance(string id)
        {
            Id = id;
        }

        public string ActivityId { get; set; }
        public WorkflowInstance WorkflowInstance { get; set; }
        public string Type { get; set; }
        public JObject State { get; set; }
        public JObject Output { get; set; }

        public Guid HandlerUserId { get; set; }
    }
}