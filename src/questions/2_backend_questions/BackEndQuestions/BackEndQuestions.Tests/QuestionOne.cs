using System;
using System.Collections.Generic;
using Xunit;
using SocialMedia;

namespace SocialMediaTests
{
    /// <summary>
    /// Unit tests for <see cref="LikesFormatter"/>.
    /// </summary>
    public class LikesFormatterTests
    {
        [Fact]
        public void FormatLikes_WithEmptyList_ReturnsNoOneLikesThis()
        {
            // Arrange
            var names = new List<string>();

            // Act
            var result = LikesFormatter.FormatLikes(names);

            // Assert
            Assert.Equal("no one likes this", result);
        }

        [Fact]
        public void FormatLikes_WithOneName_ReturnsSingleLike()
        {
            // Arrange
            var names = new List<string> { "Peter" };

            // Act
            var result = LikesFormatter.FormatLikes(names);

            // Assert
            Assert.Equal("Peter likes this", result);
        }

        [Fact]
        public void FormatLikes_WithTwoNames_ReturnsDualLike()
        {
            // Arrange
            var names = new List<string> { "Jacob", "Alex" };

            // Act
            var result = LikesFormatter.FormatLikes(names);

            // Assert
            Assert.Equal("Jacob and Alex like this", result);
        }

        [Fact]
        public void FormatLikes_WithThreeNames_ReturnsTripleLike()
        {
            // Arrange
            var names = new List<string> { "Max", "John", "Mark" };

            // Act
            var result = LikesFormatter.FormatLikes(names);

            // Assert
            Assert.Equal("Max, John and Mark like this", result);
        }

        [Fact]
        public void FormatLikes_WithFourNames_ReturnsNamesWithOthers()
        {
            // Arrange
            var names = new List<string> { "Alex", "Jacob", "Mark", "Max" };

            // Act
            var result = LikesFormatter.FormatLikes(names);

            // Assert
            Assert.Equal("Alex, Jacob and 2 others like this", result);
        }

        [Fact]
        public void FormatLikes_WhenNull_ThrowsArgumentNullException()
        {
            // Arrange
            IList<string> names = null;

            // Act & Assert
            Assert.Throws<ArgumentNullException>(() => LikesFormatter.FormatLikes(names));
        }
    }
}
