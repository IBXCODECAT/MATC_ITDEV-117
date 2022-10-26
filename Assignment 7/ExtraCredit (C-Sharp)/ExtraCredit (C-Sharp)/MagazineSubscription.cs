namespace com.schmitt.assignment7
{
    internal class MagazineSubscription
    {
        private string subscriberName = string.Empty;
        private string magazineName = string.Empty;
        private byte monthsRemaining; //We use a byte here becasue our range is 0-12 which fits in the byte bounds 0-255

        #region getters

        /// <summary>
        /// Get the subscriber name field for this object
        /// </summary>
        /// <returns>A string representing the subscriber name field of this object</returns>
        internal string getSubscriberName()
        {
            return subscriberName;
        }

        /// <summary>
        /// Get the magazine name field for this object
        /// </summary>
        /// <returns>A string representing the magazine name field of this object</returns>
        internal string getMagazineName()
        {
            return magazineName;
        }

        /// <summary>
        /// Get the months remaining field for this object
        /// </summary>
        /// <returns>A byte representing the months remaining field for this object</returns>
        internal byte getMonthsRemaining()
        {
            return monthsRemaining;
        }

        #endregion getters

        #region setters

        /// <summary>
        /// Sets the subscriber name field for this object
        /// </summary>
        /// <param name="subscriberName">A string indicitive of the subscriber name for this object</param>
        internal void setSubscriberName(string subscriberName)
        {
            this.subscriberName = subscriberName;
        }

        /// <summary>
        /// Sets the magazine name field for this object
        /// </summary>
        /// <param name="magazineName">A string indicitive of the magazine name for this object</param>
        internal void setMagazineName(string magazineName)
        {
            this.magazineName = magazineName;
        }

        /// <summary>
        /// Sets the months remaining field for this object
        /// </summary>
        /// <param name="monthsRemaining">A byte indicitive of the months remainining for this object</param>
        internal void setMonthsRemaining(byte monthsRemaining)
        {
            this.monthsRemaining = monthsRemaining;
        }

        #endregion setters
    }
}
