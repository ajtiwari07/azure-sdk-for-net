// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;

namespace Azure.ResourceManager.DataMigration.Models
{
    /// <summary> The MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult. </summary>
    public partial class MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult : MigrateSqlServerSqlDBTaskOutput
    {
        /// <summary> Initializes a new instance of MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult. </summary>
        internal MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult()
        {
            ResultType = "MigrationDatabaseLevelValidationOutput";
        }

        /// <summary> Initializes a new instance of MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult. </summary>
        /// <param name="id"> Result identifier. </param>
        /// <param name="resultType"> Result type. </param>
        /// <param name="migrationId"> Migration Identifier. </param>
        /// <param name="sourceDatabaseName"> Name of the source database. </param>
        /// <param name="targetDatabaseName"> Name of the target database. </param>
        /// <param name="startedOn"> Validation start time. </param>
        /// <param name="endedOn"> Validation end time. </param>
        /// <param name="dataIntegrityValidationResult"> Provides data integrity validation result between the source and target tables that are migrated. </param>
        /// <param name="schemaValidationResult"> Provides schema comparison result between source and target database. </param>
        /// <param name="queryAnalysisValidationResult"> Results of some of the query execution result between source and target database. </param>
        /// <param name="status"> Current status of validation at the database level. </param>
        internal MigrateSqlServerSqlDBTaskOutputDatabaseLevelValidationResult(string id, string resultType, string migrationId, string sourceDatabaseName, string targetDatabaseName, DateTimeOffset? startedOn, DateTimeOffset? endedOn, DataIntegrityValidationResult dataIntegrityValidationResult, SchemaComparisonValidationResult schemaValidationResult, QueryAnalysisValidationResult queryAnalysisValidationResult, ValidationStatus? status) : base(id, resultType)
        {
            MigrationId = migrationId;
            SourceDatabaseName = sourceDatabaseName;
            TargetDatabaseName = targetDatabaseName;
            StartedOn = startedOn;
            EndedOn = endedOn;
            DataIntegrityValidationResult = dataIntegrityValidationResult;
            SchemaValidationResult = schemaValidationResult;
            QueryAnalysisValidationResult = queryAnalysisValidationResult;
            Status = status;
            ResultType = resultType ?? "MigrationDatabaseLevelValidationOutput";
        }

        /// <summary> Migration Identifier. </summary>
        public string MigrationId { get; }
        /// <summary> Name of the source database. </summary>
        public string SourceDatabaseName { get; }
        /// <summary> Name of the target database. </summary>
        public string TargetDatabaseName { get; }
        /// <summary> Validation start time. </summary>
        public DateTimeOffset? StartedOn { get; }
        /// <summary> Validation end time. </summary>
        public DateTimeOffset? EndedOn { get; }
        /// <summary> Provides data integrity validation result between the source and target tables that are migrated. </summary>
        public DataIntegrityValidationResult DataIntegrityValidationResult { get; }
        /// <summary> Provides schema comparison result between source and target database. </summary>
        public SchemaComparisonValidationResult SchemaValidationResult { get; }
        /// <summary> Results of some of the query execution result between source and target database. </summary>
        public QueryAnalysisValidationResult QueryAnalysisValidationResult { get; }
        /// <summary> Current status of validation at the database level. </summary>
        public ValidationStatus? Status { get; }
    }
}
