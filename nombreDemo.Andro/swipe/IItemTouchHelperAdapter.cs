namespace App1.swipe
{
    interface IItemTouchHelperAdapter
    {
        void OnItemMove(int fromPosition, int toPosition);
        void OnItemDismiss(int position);
    }
}