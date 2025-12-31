class MyCircularQueue {
private:
    int* arr;
    int size;
    int head;   
    int tail;   
    int count;  
public:
    MyCircularQueue(int k) {
        size = k;
        arr = new int[size];
        head = 0;
        tail = 0;
        count = 0;
    }
    
    bool enQueue(int value) {
        if (isFull()) return false;

        arr[tail] = value;
        tail = (tail + 1) % size;
        count++;
        return true;
    }
    
    bool deQueue() {
        if (isEmpty()) return false;

        head = (head + 1) % size;
        count--;
        return true;
    }
    
    int Front() {
        if (isEmpty()) return -1;
        return arr[head];
    }
    
    int Rear() {
        if (isEmpty()) return -1;
        int idx = (tail - 1 + size) % size;
        return arr[idx];
    }
    
    bool isEmpty() {
        return count == 0;
    }
    
    bool isFull() {
        return count == size;
    }
};


/**
 * Your MyCircularQueue object will be instantiated and called as such:
 * MyCircularQueue* obj = new MyCircularQueue(k);
 * bool param_1 = obj->enQueue(value);
 * bool param_2 = obj->deQueue();
 * int param_3 = obj->Front();
 * int param_4 = obj->Rear();
 * bool param_5 = obj->isEmpty();
 * bool param_6 = obj->isFull();
 */