using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;

namespace System.Windows.Forms.Data
{
    public static class BindingListExtensions
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

        public static BindingList<T> ToConvertableBindingList<T, U>
            (this ObservableCollection<U> source, TypeConverter typeConverter)
            where T : class, new()
            where U : class
        {
            if (source is null)
            {
                throw new ArgumentNullException("source");
            }

            return (BindingList<T>)new ObservableBackedConvertableBindingList<T, U>(source, typeConverter);
        }

        internal static List<T> ConvertListElements<T, U>
            (ObservableCollection<U> sourceList, TypeConverter typeConverter)
            where T : class, new()
            where U : class
        {
            if (typeConverter is null)
            {
                // Can only be null if T is U, because then there is nothing to convert.:
                return typeof(T) == typeof(U)
                    ? sourceList
                        .Select(item => (T)(object)item)
                        .ToList()
                    : throw new ArgumentNullException(nameof(typeConverter), "Can't accept null when input and output elemen types are different.");
            }

            return sourceList
                .Select(item => (T)typeConverter.ConvertFrom(item))
                .ToList();
        }
    }
}
