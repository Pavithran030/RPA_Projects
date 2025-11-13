using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using UiPath.CodedWorkflows;
using UiPath.CodedWorkflows.Interfaces;
using UiPath.Activities.Contracts;
using FeesConcession_Process;

[assembly: WorkflowRunnerServiceAttribute(typeof(FeesConcession_Process.WorkflowRunnerService))]
namespace FeesConcession_Process
{
    public class WorkflowRunnerService
    {
        private readonly ICodedWorkflowServices _services;
        public WorkflowRunnerService(ICodedWorkflowServices services)
        {
            _services = services;
        }

        /// <summary>
        /// Invokes the Generate_Approval_PDF.xaml.cs
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Generate_Approval_PDF_xaml(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Generate_Approval_PDF.xaml.cs", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Generate_Approval_PDF.xaml.cs
        /// </summary>
        public void Generate_Approval_PDF_xaml()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Generate_Approval_PDF.xaml.cs", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Main(System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Main.xaml
        /// </summary>
        public void Main()
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Main.xaml", new Dictionary<string, object> { }, default, default, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Process_Single_Student.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public System.Data.DataTable Process_Single_Student(System.Data.DataTable in_dt_MasterData, System.Data.DataRow in_CurrentStudentRow, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process_Single_Student.xaml", new Dictionary<string, object> { { "in_dt_MasterData", in_dt_MasterData }, { "in_CurrentStudentRow", in_CurrentStudentRow } }, default, isolated, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dt_UpdatedMasterData"];
        }

        /// <summary>
        /// Invokes the Process_Single_Student.xaml
        /// </summary>
        public System.Data.DataTable Process_Single_Student(System.Data.DataTable in_dt_MasterData, System.Data.DataRow in_CurrentStudentRow)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Process_Single_Student.xaml", new Dictionary<string, object> { { "in_dt_MasterData", in_dt_MasterData }, { "in_CurrentStudentRow", in_CurrentStudentRow } }, default, default, default, GetAssemblyName());
            return (System.Data.DataTable)result["out_dt_UpdatedMasterData"];
        }

        /// <summary>
        /// Invokes the Send_Email.xaml
        /// </summary>
		/// <param name="isolated">Indicates whether to isolate executions (run them within a different process)</param>
        public void Send_Email(string in_AttachmentPath, string in_Body, string in_Subject, string in_EmailTo, System.Boolean isolated)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Send_Email.xaml", new Dictionary<string, object> { { "in_AttachmentPath", in_AttachmentPath }, { "in_Body", in_Body }, { "in_Subject", in_Subject }, { "in_EmailTo", in_EmailTo } }, default, isolated, default, GetAssemblyName());
        }

        /// <summary>
        /// Invokes the Send_Email.xaml
        /// </summary>
        public void Send_Email(string in_AttachmentPath, string in_Body, string in_Subject, string in_EmailTo)
        {
            var result = _services.WorkflowInvocationService.RunWorkflow(@"Send_Email.xaml", new Dictionary<string, object> { { "in_AttachmentPath", in_AttachmentPath }, { "in_Body", in_Body }, { "in_Subject", in_Subject }, { "in_EmailTo", in_EmailTo } }, default, default, default, GetAssemblyName());
        }

        private string GetAssemblyName()
        {
            var assemblyProvider = _services.Container.Resolve<ILibraryAssemblyProvider>();
            return assemblyProvider.GetLibraryAssemblyName(GetType().Assembly);
        }
    }
}