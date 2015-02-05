using System.Diagnostics;

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


        /// <summary>
        /// Gets or sets the feedback identifier.
        /// </summary>
        /// <value>
        /// The feedback identifier.
        /// </value>
        public string FeedbackId
        {
            get { return this._feedbackId; }
            set
            {
                Trace.Assert(value != null, "Invalid Feedback ID");
                this._feedbackId = value;
            }
        }

        /// <summary>
        /// Gets or sets the costumer identifier.
        /// </summary>
        /// <value>
        /// The costumer identifier.
        /// </value>
        public string CostumerId
        {
            get { return this._customerId; }
            set
            {
                Trace.Assert(value != null, "Invalid Customer ID");
                this._customerId = value;
            }
        }

        /// <summary>
        /// Gets or sets the software identifier.
        /// </summary>
        /// <value>
        /// The software identifier.
        /// </value>
        public string SoftwareId
        {
            get { return this._softwareId; }
            set
            {
                Trace.Assert(value != null, "Invalid Software ID");
                this._softwareId = value;
            }
        }

        /// <summary>
        /// Gets or sets the supported identifier.
        /// </summary>
        /// <value>
        /// The supported identifier.
        /// </value>
        public string SupportedId
        {
            get { return this._supportedId; }
            set
            {
                Trace.Assert(value != null, "Invalid Supported ID");
                this._supportedId = value;
            }
        }

        /// <summary>
        /// Gets or sets the date opened.
        /// </summary>
        /// <value>
        /// The date opened.
        /// </value>
        public string DateOpened
        {
            get { return this._dateOpened; }
            set
            {
                Trace.Assert(value != null, "Invalid Date Opened");
                this._dateOpened = value;
            }
        }

        /// <summary>
        /// Gets or sets the date closed.
        /// </summary>
        /// <value>
        /// The date closed.
        /// </value>
        public string DateClosed
        {
            get { return this._dateClosed; }
            set
            {
                Trace.Assert(value != null, "Invalid Date Closed");
                this._dateClosed = value;
            }
        }

        /// <summary>
        /// Gets or sets the title.
        /// </summary>
        /// <value>
        /// The title.
        /// </value>
        public string Title
        {
            get { return this._title; }
            set
            {
                Trace.Assert(value != null, "Invalid Title");
                this._title = value;
            }
        }

        /// <summary>
        /// Gets or sets the description.
        /// </summary>
        /// <value>
        /// The description.
        /// </value>
        public string Description
        {
            get { return this._description; }
            set
            {
                Trace.Assert(value != null, "Invalid Description");
                this._description = value;
            }
        }

        public string FormatFeedback()
        {
            return "Feedback for software" + this._softwareId + " closed " + this._dateClosed + " (" + this._description + ")";
        }
    }
}