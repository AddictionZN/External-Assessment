using System;
using System.Collections.Generic;

namespace SocialMedia
{
    /// <summary>
    /// Provides functionality to generate a descriptive string based on a list of names
    /// that indicate who likes a particular post.
    /// </summary>
    public static class LikesFormatter
    {
        /// <summary>
        /// Returns a formatted string describing who likes a post, depending on the number of people in the list.
        /// </summary>
        /// <param name="names">A list of names of people who liked the post.</param>
        /// <returns>A formatted string representing the likes.</returns>
        /// <exception cref="ArgumentNullException">Thrown when the <paramref name="names"/> parameter is null.</exception>
        public static string FormatLikes(IList<string> names)
        {
            if (names is null)
            {
                throw new ArgumentNullException(nameof(names), "The list of names cannot be null.");
            }

            return names.Count switch
            {
                0 => "no one likes this",
                1 => $"{names[0]} likes this",
                2 => $"{names[0]} and {names[1]} like this",
                3 => $"{names[0]}, {names[1]} and {names[2]} like this",
                _ => $"{names[0]}, {names[1]} and {names.Count - 2} others like this"
            };
        }
    }
}
