using System;
using System.Collections.ObjectModel;
using System.ComponentModel;

namespace System.Windows.Forms.Data
{
    public static class BindingListExtension
    {
        /// <summary>
        /// Returns an <see cref="BindingList{T}"/> implementation that stays in sync with the given <see cref="ObservableCollection{T}"/>.
        /// </summary>
        /// <typeparam name="T">The element type.</typeparam>
        /// <param name="source">The collection that the binding list will stay in sync with.</param>
        /// <returns>The binding list.</returns>
        public static BindingList<T> ToBindingList<T>(this ObservableCollection<T> source) where T : class
        {
            if (source is null)
            {
                throw new ArgumentNullException("source");
            }

            return new ObservableBackedBindingList<T>(source);
        }
    }
}
