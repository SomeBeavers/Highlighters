namespace Highlighters
{
    //IRefactoringsPreview
    public class RefactoringsPreview : IRefactoringsPreview
    {
        public void Preview1(string name)
        {
            throw new System.NotImplementedException();
        }
    }
    public class RefactoringsPreview2 : IRefactoringsPreview
    {
        public void Preview1(string name)
        {
            throw new System.NotImplementedException();
        }
    }
    public class RefactoringsPreview3 : IRefactoringsPreview
    {
        public void Preview1(string name)
        {
            throw new System.NotImplementedException();
        }
    }
    public class RefactoringsPreview4 : IRefactoringsPreview
    {
        public void Preview1(string name)
        {
            throw new System.NotImplementedException();
        }
        public void Preview2(string name = "")
        {
            Preview1(name);
            throw new System.NotImplementedException();
        }
    }
    public class RefactoringsPreview5 : IRefactoringsPreview
    {
        public void Preview1(string name)
        {
            throw new System.NotImplementedException();
        }
    }
}