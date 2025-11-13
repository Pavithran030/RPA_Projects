using UiPath.CodedWorkflows;
using System;

namespace FeesConcession_Process
{
    public class GoogleDocsFactory
    {
        public GoogleDocsFactory(ICodedWorkflowsServiceContainer resolver)
        {
        }
    }

    public class DriveFactory
    {
        public UiPath.GSuite.Activities.Api.DriveConnection My_Workspace_techpavithran18_gmail_com { get; set; }

        public DriveFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_techpavithran18_gmail_com = new UiPath.GSuite.Activities.Api.DriveConnection("001b2345-2ecf-42c7-ba9e-89badbaad309", resolver);
        }
    }

    public class GmailFactory
    {
        public UiPath.GSuite.Activities.Api.GmailConnection My_Workspace_techpavithran18_gmail_com { get; set; }

        public GmailFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_techpavithran18_gmail_com = new UiPath.GSuite.Activities.Api.GmailConnection("d5304a3c-67e0-4fd0-9a13-18a6f860f6bf", resolver);
        }
    }

    public class GoogleSheetsFactory
    {
        public UiPath.GSuite.Activities.Api.SheetsConnection My_Workspace_techpavithran18_gmail_com { get; set; }

        public GoogleSheetsFactory(ICodedWorkflowsServiceContainer resolver)
        {
            My_Workspace_techpavithran18_gmail_com = new UiPath.GSuite.Activities.Api.SheetsConnection("e62e51e4-8fe9-4ae7-b3f7-d003c626fc9c", resolver);
        }
    }
}