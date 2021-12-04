using System.Threading;
using System.Threading.Tasks;
using Xunit;

namespace Design.Patterns.OOP.Tests.Clean_Code.SingletonTests
{
    public class SingletonTests
    {
        private S s1 = null;
        private S s2 = null;

        [Fact]
        public async Task Singletons_CreatedProperly()
        {
            new Thread(() => s1 = S.GetInstance()).Start();
            new Thread(() => s2 = S.GetInstance()).Start();

            while (s1 == null || s2 == null)
                Thread.Sleep(1);

            Assert.Equal(s1, s2);
        }
    }

    class S
    {
        private static S instance = null;
        public static int k = 1;
        public int constant;
        static object Lock = new object();

        private S(int n)
        {
            constant = n;
        }

        public static S GetInstance()
        {
            if (instance is null)
            {
                lock (Lock)
                {
                    if (instance is null)
                    {
                        instance = new S(X.k);
                    }

                    return instance;
                }
            }

            return instance;
        }
    }

    class X
    {
        private static X instance = null;
        public static int k = 2;
        public int constant;

        private X(int n)
        {
            constant = n;
        }

        public static X GetInstance()
        {
            if (instance is null)
                instance = new X(S.k);

            return instance;
        }
    }
}