﻿//////////////////////////////// 
// 
//   Copyright 2021 Battelle Energy Alliance, LLC  
// 
// 
//////////////////////////////// 
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace CSETWebCore.Business.AssessmentIO.Import
{
    interface IImportAssessmentRule
    {
        void ProcessRule(JToken jObj, XmlElement xTable, DBIO dBIO);
    }
}