﻿// Copyright 2013-2019 Dirk Lemstra <https://github.com/dlemstra/Magick.NET/>
//
// Licensed under the ImageMagick License (the "License"); you may not use this file except in
// compliance with the License. You may obtain a copy of the License at
//
//   https://www.imagemagick.org/script/license.php
//
// Unless required by applicable law or agreed to in writing, software distributed under the
// License is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND,
// either express or implied. See the License for the specific language governing permissions
// and limitations under the License.

using ImageMagick;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Magick.NET.Tests
{
    public partial class NumberTests
    {
        [TestClass]
        public class TheEqualsMethod
        {
            [TestMethod]
            public void ShouldReturnTrueWhenInstanceIsTheSame()
            {
                var number = new Number(10);

                Assert.IsTrue(number.Equals(number));
            }

            [TestMethod]
            public void ShouldReturnTrueWhenObjectIsTheSame()
            {
                var number = new Number(10);

                Assert.IsTrue(number.Equals((object)number));
            }

            [TestMethod]
            public void ShouldReturnTrueWhenInstanceIsEqual()
            {
                var first = new Number(10);
                var second = new Number(10);

                Assert.IsTrue(first.Equals(second));
            }

            [TestMethod]
            public void ShouldReturnTrueWhenObjectIsEqual()
            {
                var first = new Number(10);
                var second = new Number(10);

                Assert.IsTrue(first.Equals((object)second));
            }

            [TestMethod]
            public void ShouldReturnFalseWhenInstanceIsNotEqual()
            {
                var first = new Number(10);
                var second = new Number(20);

                Assert.IsFalse(first.Equals(second));
            }

            [TestMethod]
            public void ShouldReturnFalseWhenObjectIsNotEqual()
            {
                var first = new Number(10);
                var second = new Number(20);

                Assert.IsFalse(first.Equals((object)second));
            }
        }
    }
}
