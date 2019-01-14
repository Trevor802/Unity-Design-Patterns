namespace FacadePattern
{
    public class Facade
    {
        private SubSystemA systemA = new SubSystemA();
        private SubSystemB systemB = new SubSystemB();
        private SubSystemC systemC = new SubSystemC();

        public void MethodA()
        {
            systemA.MethodA();
            systemB.MethodB();
        }

        public void MethodB()
        {
            systemB.MethodB();
            systemC.MethodC();
        }
    }
}