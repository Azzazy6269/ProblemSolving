#include <iostream>

using namespace std;
class MyLinkedList {
    struct Node {
        int val;
        Node* previous = nullptr;
        Node* next = nullptr;
        Node(int _val) {
            val = _val;
        }
    };

    Node* head;
    Node* tail;
    int length;

public:
    MyLinkedList() {
        head = tail = nullptr;
        length = 0;
    }

    bool isEmpty() {
        if(head == nullptr)
            return true;
        return false;
    }

       int get(int index) {
        if(index < 0 || index >= length || isEmpty()) {
            return -1;
        }
        Node* temp = head;
        for(int i = 0; i < index; i++) {
            temp = temp->next;
        }
        return temp->val;
    }

    void addAtHead(int val) {
        Node* temp = new Node(val);
        if(isEmpty()) {
            head = tail = temp;
        } else {
            temp->next = head;
            head->previous = temp;
            head = temp;
        }
        length++;
    }

    void addAtTail(int val) {
        Node* temp = new Node(val);
        if(isEmpty()) {
            head = tail = temp;
        } else {
            temp->previous = tail;
            tail->next = temp;
            tail = temp;
        }
        length++;
    }

    void addAtIndex(int index, int val) {
        if(index < 0 || index > length) {
            return;
        }
        if(index == 0) {
            addAtHead(val);
            return;
        }
        if(index == length) {
            addAtTail(val);
            return;
        }

        Node* newNode = new Node(val);
        Node* temp = head;
        for(int i = 0; i < index; i++) {
            temp = temp->next;
        }

        newNode->next = temp;
        newNode->previous = temp->previous;
        temp->previous->next = newNode;
        temp->previous = newNode;
        length++;
    }

    void deleteAtIndex(int index) {
        if(isEmpty() || index < 0 || index >= length) {
            return;
        }

        Node* temp = head;
        for(int i = 0; i < index; i++) {
            temp = temp->next;
        }

        if(tail == temp) {
            if(length == 1) {
                delete head;
                head = tail = nullptr;
            } else {
                tail->previous->next = nullptr;
                tail = tail->previous;
                delete temp;
            }
        } else if(head == temp) {
            head->next->previous = nullptr;
            head = head->next;
            delete temp;
        } else {
            temp->previous->next = temp->next;
            temp->next->previous = temp->previous;
            delete temp;
        }
        length--;
    }

};

/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList* obj = new MyLinkedList();
 * int param_1 = obj->get(index);
 * obj->addAtHead(val);
 * obj->addAtTail(val);
 * obj->addAtIndex(index,val);
 * obj->deleteAtIndex(index);
 */
/**
 * Your MyLinkedList object will be instantiated and called as such:
 * MyLinkedList* obj = new MyLinkedList();
 * int param_1 = obj->get(index);
 * obj->addAtHead(val);
 * obj->addAtTail(val);
 * obj->addAtIndex(index,val);
 * obj->deleteAtIndex(index);
 */
int main()
{
    return 0;
}
