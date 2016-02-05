using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using Prism.Regions;


namespace PrismDemo.Infrastructure
{
    public class StackPanelRegionAdapter : RegionAdapterBase<StackPanel>
    {
        public StackPanelRegionAdapter(IRegionBehaviorFactory regionBehaviorFactory) : base(regionBehaviorFactory)
        {
        }

        protected override void Adapt(IRegion region, StackPanel regionTarget)
        {
            region.Views.CollectionChanged += (s, e) =>
            {

                if (e.Action == NotifyCollectionChangedAction.Add || e.Action == NotifyCollectionChangedAction.Remove)
                {
                    foreach (FrameworkElement element in e.NewItems)
                    {
                        if (e.Action == NotifyCollectionChangedAction.Add)
                        {
                            regionTarget.Children.Add(element);
                        }
                        else
                        {
                            if (regionTarget.Children.Contains(element))
                            {
                                regionTarget.Children.Remove(element);
                            }

                        }
                    }
                }
            };
        }



        protected override IRegion CreateRegion()
        {
           return new AllActiveRegion();
        }
    }
}
