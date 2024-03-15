// Given the head of a singly linked list, reverse the list, and return the reversed list.
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode ReverseList(ListNode head) {
        if (head == null || head.next == null) {
            return head;
        }

        var nodeMap = new Dictionary<int,int>();
        var nodeIndex = 0;
        mapList(head, nodeMap, nodeIndex);

        ListNode newHead = new ListNode(nodeMap[nodeMap.Count - 1]);
        ListNode previous = null;

        for (int i = nodeMap.Count - 2; i >= 0; i--) {
            Console.WriteLine(i);
            var newNode = new ListNode(nodeMap[i]);
            if (previous != null) {
                previous.next = newNode;
            }
            if (i == nodeMap.Count - 2) {
                newHead.next = newNode;
            }
            previous = newNode;
        }
        
        return newHead;
    }
    
    private void mapList(ListNode node, Dictionary<int,int> nodeMap, int nodeIndex) {
        if (!nodeMap.ContainsKey(nodeIndex)) {
            nodeMap.Add(nodeIndex, node.val);
        }
        
        nodeIndex++;
        
        if (node.next != null) {
            mapList(node.next, nodeMap, nodeIndex);
        }
    }
}