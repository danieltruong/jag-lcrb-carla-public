// <auto-generated>
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Gov.Lclb.Cllb.Interfaces.Models
{
    using Newtonsoft.Json;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;

    public partial class MicrosoftDynamicsCRMgoalrollupquery
    {
        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMgoalrollupquery class.
        /// </summary>
        public MicrosoftDynamicsCRMgoalrollupquery()
        {
            CustomInit();
        }

        /// <summary>
        /// Initializes a new instance of the
        /// MicrosoftDynamicsCRMgoalrollupquery class.
        /// </summary>
        public MicrosoftDynamicsCRMgoalrollupquery(IList<MicrosoftDynamicsCRMduplicaterecord> goalRollupQueryDuplicateBaseRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMduplicaterecord> goalRollupQueryDuplicateMatchingRecord = default(IList<MicrosoftDynamicsCRMduplicaterecord>), IList<MicrosoftDynamicsCRMsyncerror> goalRollupQuerySyncErrors = default(IList<MicrosoftDynamicsCRMsyncerror>), string _createdbyValue = default(string), string _createdonbehalfbyValue = default(string), string _modifiedbyValue = default(string), string _modifiedonbehalfbyValue = default(string), string _owneridValue = default(string), string _owningbusinessunitValue = default(string), string _owningteamValue = default(string), string _owninguserValue = default(string), MicrosoftDynamicsCRMsystemuser createdby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? createdon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser createdonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string fetchxml = default(string), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryActualdecimal = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryActualmoney = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryCustomdecimal = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryCustomint = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryCustommoney = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryInprogressdecimal = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryInprogressint = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMgoal> goalRollupqueryInprogressmoney = default(IList<MicrosoftDynamicsCRMgoal>), IList<MicrosoftDynamicsCRMasyncoperation> goalrollupqueryAsyncOperations = default(IList<MicrosoftDynamicsCRMasyncoperation>), IList<MicrosoftDynamicsCRMgoal> goalrollupqueryActualint = default(IList<MicrosoftDynamicsCRMgoal>), string goalrollupqueryid = default(string), int? importsequencenumber = default(int?), MicrosoftDynamicsCRMsystemuser modifiedby = default(MicrosoftDynamicsCRMsystemuser), System.DateTimeOffset? modifiedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMsystemuser modifiedonbehalfby = default(MicrosoftDynamicsCRMsystemuser), string name = default(string), System.DateTimeOffset? overriddencreatedon = default(System.DateTimeOffset?), MicrosoftDynamicsCRMprincipal ownerid = default(MicrosoftDynamicsCRMprincipal), MicrosoftDynamicsCRMbusinessunit owningbusinessunit = default(MicrosoftDynamicsCRMbusinessunit), MicrosoftDynamicsCRMteam owningteam = default(MicrosoftDynamicsCRMteam), string queryentitytype = default(string), int? statecode = default(int?), int? statuscode = default(int?), int? timezoneruleversionnumber = default(int?), int? utcconversiontimezonecode = default(int?), object versionnumber = default(object))
        {
            GoalRollupQueryDuplicateBaseRecord = goalRollupQueryDuplicateBaseRecord;
            GoalRollupQueryDuplicateMatchingRecord = goalRollupQueryDuplicateMatchingRecord;
            GoalRollupQuerySyncErrors = goalRollupQuerySyncErrors;
            this._createdbyValue = _createdbyValue;
            this._createdonbehalfbyValue = _createdonbehalfbyValue;
            this._modifiedbyValue = _modifiedbyValue;
            this._modifiedonbehalfbyValue = _modifiedonbehalfbyValue;
            this._owneridValue = _owneridValue;
            this._owningbusinessunitValue = _owningbusinessunitValue;
            this._owningteamValue = _owningteamValue;
            this._owninguserValue = _owninguserValue;
            Createdby = createdby;
            Createdon = createdon;
            Createdonbehalfby = createdonbehalfby;
            Fetchxml = fetchxml;
            GoalRollupqueryActualdecimal = goalRollupqueryActualdecimal;
            GoalRollupqueryActualmoney = goalRollupqueryActualmoney;
            GoalRollupqueryCustomdecimal = goalRollupqueryCustomdecimal;
            GoalRollupqueryCustomint = goalRollupqueryCustomint;
            GoalRollupqueryCustommoney = goalRollupqueryCustommoney;
            GoalRollupqueryInprogressdecimal = goalRollupqueryInprogressdecimal;
            GoalRollupqueryInprogressint = goalRollupqueryInprogressint;
            GoalRollupqueryInprogressmoney = goalRollupqueryInprogressmoney;
            GoalrollupqueryAsyncOperations = goalrollupqueryAsyncOperations;
            GoalrollupqueryActualint = goalrollupqueryActualint;
            Goalrollupqueryid = goalrollupqueryid;
            Importsequencenumber = importsequencenumber;
            Modifiedby = modifiedby;
            Modifiedon = modifiedon;
            Modifiedonbehalfby = modifiedonbehalfby;
            Name = name;
            Overriddencreatedon = overriddencreatedon;
            Ownerid = ownerid;
            Owningbusinessunit = owningbusinessunit;
            Owningteam = owningteam;
            Queryentitytype = queryentitytype;
            Statecode = statecode;
            Statuscode = statuscode;
            Timezoneruleversionnumber = timezoneruleversionnumber;
            Utcconversiontimezonecode = utcconversiontimezonecode;
            Versionnumber = versionnumber;
            CustomInit();
        }

        /// <summary>
        /// An initialization method that performs custom operations like setting defaults
        /// </summary>
        partial void CustomInit();

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GoalRollupQuery_DuplicateBaseRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> GoalRollupQueryDuplicateBaseRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GoalRollupQuery_DuplicateMatchingRecord")]
        public IList<MicrosoftDynamicsCRMduplicaterecord> GoalRollupQueryDuplicateMatchingRecord { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "GoalRollupQuery_SyncErrors")]
        public IList<MicrosoftDynamicsCRMsyncerror> GoalRollupQuerySyncErrors { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdby_value")]
        public string _createdbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_createdonbehalfby_value")]
        public string _createdonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedby_value")]
        public string _modifiedbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_modifiedonbehalfby_value")]
        public string _modifiedonbehalfbyValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_ownerid_value")]
        public string _owneridValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningbusinessunit_value")]
        public string _owningbusinessunitValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owningteam_value")]
        public string _owningteamValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "_owninguser_value")]
        public string _owninguserValue { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdby")]
        public MicrosoftDynamicsCRMsystemuser Createdby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdon")]
        public System.DateTimeOffset? Createdon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "createdonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Createdonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "fetchxml")]
        public string Fetchxml { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_actualdecimal")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryActualdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_actualmoney")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryActualmoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_customdecimal")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryCustomdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_customint")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryCustomint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_custommoney")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryCustommoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_inprogressdecimal")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryInprogressdecimal { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_inprogressint")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryInprogressint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goal_rollupquery_inprogressmoney")]
        public IList<MicrosoftDynamicsCRMgoal> GoalRollupqueryInprogressmoney { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalrollupquery_AsyncOperations")]
        public IList<MicrosoftDynamicsCRMasyncoperation> GoalrollupqueryAsyncOperations { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalrollupquery_actualint")]
        public IList<MicrosoftDynamicsCRMgoal> GoalrollupqueryActualint { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "goalrollupqueryid")]
        public string Goalrollupqueryid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "importsequencenumber")]
        public int? Importsequencenumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedon")]
        public System.DateTimeOffset? Modifiedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "modifiedonbehalfby")]
        public MicrosoftDynamicsCRMsystemuser Modifiedonbehalfby { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "name")]
        public string Name { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "overriddencreatedon")]
        public System.DateTimeOffset? Overriddencreatedon { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "ownerid")]
        public MicrosoftDynamicsCRMprincipal Ownerid { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningbusinessunit")]
        public MicrosoftDynamicsCRMbusinessunit Owningbusinessunit { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "owningteam")]
        public MicrosoftDynamicsCRMteam Owningteam { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "queryentitytype")]
        public string Queryentitytype { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statecode")]
        public int? Statecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "statuscode")]
        public int? Statuscode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "timezoneruleversionnumber")]
        public int? Timezoneruleversionnumber { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "utcconversiontimezonecode")]
        public int? Utcconversiontimezonecode { get; set; }

        /// <summary>
        /// </summary>
        [JsonProperty(PropertyName = "versionnumber")]
        public object Versionnumber { get; set; }

    }
}