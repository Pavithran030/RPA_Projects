using System;
using System.Collections.Generic;
using System.Data;
using UiPath.Activities.System.Jobs.Coded;
using UiPath.CodedWorkflows;
using UiPath.Core;
using UiPath.Core.Activities.Storage;
using UiPath.GSuite.Activities.Api;
using UiPath.Orchestrator.Client.Models;

namespace FeesConcession_Process
{
    public partial class CodedWorkflow : CodedWorkflowBase
    {
        private Lazy<global::FeesConcession_Process.WorkflowRunnerService> _workflowRunnerServiceLazy;
        private Lazy<ConnectionsManager> _connectionsManagerLazy;
        public CodedWorkflow()
        {
            _ = new System.Type[]
            {
                typeof(UiPath.Core.Activities.API.ISystemService),
                typeof(UiPath.GSuite.Activities.Api.IGoogleConnectionsService)
            };
            _workflowRunnerServiceLazy = new Lazy<global::FeesConcession_Process.WorkflowRunnerService>(() => new global::FeesConcession_Process.WorkflowRunnerService(this.services));
#pragma warning disable
            _connectionsManagerLazy = new Lazy<ConnectionsManager>(() => new ConnectionsManager(serviceContainer));
#pragma warning restore
        }

        protected global::FeesConcession_Process.WorkflowRunnerService workflows => _workflowRunnerServiceLazy.Value;
        protected ConnectionsManager connections => _connectionsManagerLazy.Value;
#pragma warning disable
        protected UiPath.GSuite.Activities.Api.IGoogleConnectionsService google { get => serviceContainer.Resolve<UiPath.GSuite.Activities.Api.IGoogleConnectionsService>() ; }
#pragma warning restore
#pragma warning disable
        protected UiPath.Core.Activities.API.ISystemService system { get => serviceContainer.Resolve<UiPath.Core.Activities.API.ISystemService>() ; }
#pragma warning restore
    }
}