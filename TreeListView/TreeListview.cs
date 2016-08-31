using System.Windows;
using System.Windows.Controls;

namespace TreeListViewApp
{
    public class TreeListView : TreeView
    {
        public static readonly DependencyProperty ColumnsProperty =
            DependencyProperty.Register("Columns", typeof(GridViewColumnCollection), typeof(TreeListView), new FrameworkPropertyMetadata(new GridViewColumnCollection(), FrameworkPropertyMetadataOptions.None));

        public GridViewColumnCollection Columns
        {
            get { return (GridViewColumnCollection)GetValue(ColumnsProperty); }
            set { SetValue(ColumnsProperty, value); }
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TreeListViewItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TreeListViewItem;
        }

        public TreeListView()
        {
            DefaultStyleKey = typeof(TreeListView);
            Columns = new GridViewColumnCollection();
        }
    }

    public class TreeListViewItem : TreeViewItem
    {

        private int level = -1;

        public int Level
        {
            get
            {
                if (level != -1) { return level; }

                var parent = ItemsControlFromItemContainer(this) as TreeListViewItem;
                level = (parent != null) ? parent.Level + 1 : 0;
                return level;
            }
        }

        protected override DependencyObject GetContainerForItemOverride()
        {
            return new TreeListViewItem();
        }

        protected override bool IsItemItsOwnContainerOverride(object item)
        {
            return item is TreeListViewItem;
        }

        public TreeListViewItem()
        {
            DefaultStyleKey = typeof(TreeListViewItem);
        }
    }
}