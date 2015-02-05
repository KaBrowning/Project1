using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;


namespace App_Code
{
    /// <summary>
    /// Summary description for Feedback
    /// </summary>
    public class Feedback
    {
        private string _feedbackId;
        private string _customerId;
        private string _softwareId;
        private string _supportedId;
        private string _dateOpened;
        private string _dateClosed;
        private string _title;
        private string _description;


        public string FeedbackId
        {
            get { return this._feedbackId; }
            set
            {
                Trace.Assert(value != null, "Invalid Feedback ID");
                this._feedbackId = value;
            }
        }

        public string CostumerId
        {
            get { return this._customerId; }
            set
            {
                Trace.Assert(value != null, "Invalid Customer ID");
                this._customerId = value;
            }
        }

        public string SoftwareId
        {
            get { return this._softwareId; }
            set
            {
                Trace.Assert(value != null, "Invalid Software ID");
                this._softwareId = value;
            }
        }

        public string SupportedId
        {
            get { return this._supportedId; }
            set
            {
                Trace.Assert(value != null, "Invalid Supported ID");
                this._supportedId = value;
            }
        }

        public string DateOpened
        {
            get { return this._dateOpened; }
            set
            {
                Trace.Assert(value != null, "Invalid Date Opened");
                this._dateOpened = value;
            }
        }

        public string DateClosed
        {
            get { return this._dateClosed; }
            set
            {
                Trace.Assert(value != null, "Invalid Date Closed");
                this._dateClosed = value;
            }
        }

        public string Title
        {
            get { return this._title; }
            set
            {
                Trace.Assert(value != null, "Invalid Title");
                this._title = value;
            }
        }

        public string Description
        {
            get { return this._description; }
            set
            {
                Trace.Assert(value != null, "Invalid Description");
                this._description = value;
            }
        }
    }
}