namespace API.DrugFRT.Configuration.Interface
{
    public abstract class BaseSetting
    {
        public string SqlCon { get; set; }
        protected abstract void CommonSettings();
        protected abstract void InitLive();
        protected abstract void InitStaging();
        protected abstract void InitTest();
        protected abstract void InitLocal();
        protected abstract void InitDev();

        protected BaseSetting(ApiEnvironment environment)
        {
            CommonSettings();
            switch (environment)
            {
                case ApiEnvironment.Live:
                {
                    InitLive();
                    break;
                }
                case ApiEnvironment.Staging:
                {
                    InitStaging();
                    break;
                }
                case ApiEnvironment.Test:
                {
                    InitTest();
                    break;
                }
                case ApiEnvironment.Local:
                {
                    InitLocal();
                    break;
                }
                case ApiEnvironment.Dev:
                {
                    InitDev();
                    break;
                }
            }
        }
    }
}
