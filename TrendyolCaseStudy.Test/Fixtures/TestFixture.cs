using Moq;

namespace TrendyolCaseStudy.Test
{
    /// <summary>
    /// Birim testleri Fixture sınıfları için temel sınıf.
    /// </summary>
    public abstract class TestFixture
    {
        #region verify any

        /// <summary>
        /// Moq.Mock sınıfları için Verify işlemi uygulandığında geçirilen It.IsAny tipinde parametreler için kullanılır.
        /// It.IsAny metodunun hangi bağlamda kullanıldığını tespit etmek amacıyla oluşturulmuştur.
        /// </summary>
        /// <typeparam name="T">Any olarak kullanılacak tip bilgisi</typeparam>
        /// <returns></returns>
        public static T VerifyAny<T>()
        {
            return Any<T>();
        }

        #endregion

        #region setup any

        /// <summary>
        /// Moq.Mock sınıfları için Setup işlemi uygulandığında geçirilen It.IsAny tipinde parametreler için kullanılır.
        /// It.IsAny metodunun hangi bağlamda kullanıldığını tespit etmek amacıyla oluşturulmuştur.
        /// </summary>
        /// <typeparam name="T">Any olarak kullanılacak tip bilgisi</typeparam>
        /// <returns></returns>
        public static T SetupAny<T>()
        {
            return Any<T>();
        }

        static T Any<T>()
        {
            return It.IsAny<T>();
        }

        #endregion
    }
}