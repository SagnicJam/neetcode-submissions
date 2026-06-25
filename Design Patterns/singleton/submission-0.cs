public class Singleton {

    private string value = null;
    private static Singleton uniqueInstance = null;

    //wont be publicly exposed so that people dont make object of it
    private Singleton() {

    }

    public static Singleton getInstance() {
        if(uniqueInstance==null)
        {
            uniqueInstance = new Singleton();
        }
        return uniqueInstance;
    }

    public string getValue() {
        return this.value;
    }

    public void setValue(string value){
        this.value = value;
    }
}
