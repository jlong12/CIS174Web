//[assembly: webactivatorex.preapplicationstartmethod(typeof(gameonproject.app_start.ninjectwebcommon), "start")]
//[assembly: webactivatorex.applicationshutdownmethodattribute(typeof(gameonproject.app_start.ninjectwebcommon), "stop")]

//namespace gameonproject.app_start
//{
//    using system;
//    using system.web;
//    using gameonproject.shared.orchestrators;
//    using gameonproject.shared.orchestrators.interfaces;
//    using microsoft.web.infrastructure.dynamicmodulehelper;

//    using ninject;
//    using ninject.web.common;
//    using ninject.web.common.webhost;

//    public static class ninjectwebcommon
//    {
//        private static readonly bootstrapper bootstrapper = new bootstrapper();

//        /// <summary>
//        /// starts the application
//        /// </summary>
//        public static void start()
//        {
//            dynamicmoduleutility.registermodule(typeof(oneperrequesthttpmodule));
//            dynamicmoduleutility.registermodule(typeof(ninjecthttpmodule));
//            bootstrapper.initialize(createkernel);
//        }

//        /// <summary>
//        /// stops the application.
//        /// </summary>
//        public static void stop()
//        {
//            bootstrapper.shutdown();
//        }

//        /// <summary>
//        /// creates the kernel that will manage your application.
//        /// </summary>
//        /// <returns>the created kernel.</returns>
//        private static ikernel createkernel()
//        {
//            var kernel = new standardkernel();
//            try
//            {
//                kernel.bind<func<ikernel>>().tomethod(ctx => () => new bootstrapper().kernel);
//                kernel.bind<ihttpmodule>().to<httpapplicationinitializationhttpmodule>();
//                registerservices(kernel);
//                return kernel;
//            }
//            catch
//            {
//                kernel.dispose();
//                throw;
//            }
//        }

//        /// <summary>
//        /// load your modules or register your services here!
//        /// </summary>
//        /// <param name="kernel">the kernel.</param>
//        private static void registerservices(ikernel kernel)
//        {
//            kernel.bind<iprofileorchestrator>().to<profileorchestrator>();
//        }
//    }
//}