﻿// Copyright (c) 2012-2019 fo-dicom contributors.
// Licensed under the Microsoft Public License (MS-PL).

using FellowOakDicom.IO;
using Xunit;

namespace FellowOakDicom.Imaging
{

    [Collection("Imaging")]
    public class ImageManagerTest
    {
        #region Fields

        private readonly object @lock = new object();

        #endregion

        #region Unit tests

        [Fact]
        public void SetImplementation_WinForms_ImageManagerUsesWinFormsImplementation()
        {
            lock (@lock)
            {
                var image = ImageManager.CreateImage(100, 100);
                image.Render(4, false, false, 0);
                Assert.IsType<WinFormsImage>(image);
            }
        }

        #endregion
    }
}
