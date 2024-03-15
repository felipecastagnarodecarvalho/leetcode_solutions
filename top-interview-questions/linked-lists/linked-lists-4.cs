// You are given the heads of two sorted linked lists list1 and list2.
// Merge the two lists into one sorted list. The list should be made by splicing together the nodes of the first two lists.
// Return the head of the merged linked list.
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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        if (list1 == null && list2 == null){
            return null;
        }

        var nodeMap1 = new Dictionary<int,int>();
        var nodeMap2 = new Dictionary<int,int>();
        
        mapNode(list1, nodeMap1, 0);
        mapNode(list2, nodeMap2, 0);
        
        var orderedList = new List<int>();
        
        AddToOrderedValuesList(nodeMap1, orderedList);
        AddToOrderedValuesList(nodeMap2, orderedList);
        
        orderedList.Sort();
        
        ListNode newHead = new ListNode(orderedList[0]);
        ListNode previous = null;
        
        for (int i = 1; i < orderedList.Count; i++) {
            var newNode = new ListNode(orderedList[i]);
            if (previous != null) {
                previous.next = newNode;
            } else {
                if (i == 1) {
                    newHead.next = newNode;
                }
            }
            
            previous = newNode;
        }
        
        return newHead;
    }

    private void AddToOrderedValuesList(Dictionary<int,int> nodeMap, List<int> orderedList) {
        foreach (var keyPair in nodeMap) {
            orderedList.Add(keyPair.Value);
        }
    }

    private void mapNode(ListNode node, Dictionary<int,int> nodeMap, int index) {
        if (node == null) {
            return;
        }
    
        if (!nodeMap.ContainsKey(index)) {
            nodeMap.Add(index, node.val);
        }
        
        index++;
        
        if (node.next != null) {
            mapNode(node.next, nodeMap, index);
        }
    }
}