public class UnlimitedQueue{

    int[] array;
    int front;
    int rear;
    int size;

    public UnlimitedQueue(){

        array = new int[5];
        front = 0;
        rear = -1;
        size = 0;
    }

    public void Enqueue(int val){

        if(size == array.Length){
            ResizeArray();
        }

        rear = (rear + 1) % array.Length;
        array[rear] = val;
        size++;
    }

    public int Dequeue(){

        if(size == 0)
            throw new Exception("No element found");
        
        var item = array[front];
        front = (front + 1) % array.Length;

        size--;
        return item;
    }

    void ResizeArray(){

        var newArray = new int[array.Length * 2];

        for(int i = 0; i< array.Length; i++){

            newArray[i] = array[i];
        }

        array = newArray;
    }

}