using Android.Graphics;
using Android.Support.V7.Widget;
using Android.Support.V7.Widget.Helper;
using Android.Widget;
using demo.Core.Services;
using demo.Core.ViewModels;
using System.Collections.Generic;

namespace App1.swipe
{
    class SimpleItemTouchHelperCallback : ItemTouchHelper.Callback
    {
        // private RecyclerView.Adapter adapter;
        private readonly RecyclerView.Adapter _adapter;
        RecyclerViewModel lista;
        NombreGenesisService lista2;
        public SimpleItemTouchHelperCallback(RecyclerView.Adapter adapter)
        {
            _adapter = adapter;
            lista = new RecyclerViewModel();
            lista2 = new NombreGenesisService();
        }

        public override void ClearView(RecyclerView p0, RecyclerView.ViewHolder viewHolder)
        {
            base.ClearView(p0, viewHolder);
        }

        public override int GetMovementFlags(RecyclerView p0, RecyclerView.ViewHolder p1)
        {
            int dragFlags = ItemTouchHelper.Up | ItemTouchHelper.Down;
            int swipeFlags = ItemTouchHelper.Start | ItemTouchHelper.End;
            return MakeMovementFlags(dragFlags, swipeFlags);
        }

        public override bool OnMove(RecyclerView p0, RecyclerView.ViewHolder p1, RecyclerView.ViewHolder p2)
        {
            _adapter.NotifyItemMoved(p1.AdapterPosition, p2.AdapterPosition);
            return true;
        }

        public override void OnSwiped(RecyclerView.ViewHolder p0, int p1)
        {
            //lista.CreateNewNombre();
            //lista.deleteItem(p0.AdapterPosition);          
            // lista.Items.RemoveAt(p0.AdapterPosition);
            RecyclerViewModel rvm = new RecyclerViewModel();
            rvm.Items.RemoveAt(p0.AdapterPosition);

            _adapter.NotifyItemChanged(p0.AdapterPosition);
            _adapter.NotifyItemRemoved(p0.AdapterPosition);
        }

    }
}