// Given the head of a linked list, remove the nth node from the end of the list and return its head.
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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {      
        if (head.next  == null) {
            return null;
        }
        
        var nodeMapList = new List<ListNode>();
        FillNodeMapList(head, nodeMapList);
        
        var targetNode = nodeMapList[nodeMapList.Count - n];
        ListNode newHead = null;
        ListNode previous = null;
        
        for (int i = 0; i < nodeMapList.Count; i++) {
            if (nodeMapList[i] != targetNode) {
                var newNode = new ListNode(nodeMapList[i].val);
                if (previous != null) {
                    previous.next = newNode;
                }
                if (newHead == null) {
                    newHead = newNode;
                }
                previous = newNode;
            }
        }

        return newHead;
    }
    
    private void FillNodeMapList(ListNode node, List<ListNode> nodeMapList) {
        if (!nodeMapList.Contains(node)) {
            nodeMapList.Add(node);
        }        
        if (node.next != null) {
            FillNodeMapList(node.next, nodeMapList);
        }
    }
}