﻿/*
    Copyright (C) 2014 Omega software d.o.o.

    This file is part of Rhetos.

    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU Affero General Public License as
    published by the Free Software Foundation, either version 3 of the
    License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU Affero General Public License for more details.

    You should have received a copy of the GNU Affero General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
*/

using System;
using System.IO;
using Rhetos.Utilities;

namespace Rhetos.FloydExtensions
{
    public class MetadataProvider
    {
        private readonly Lazy<string> _metadata;

        public MetadataProvider(IAssetsOptions assetsOptions)
        {
            _metadata = new Lazy<string> (() =>
            {
                var fileName = Path.Combine(assetsOptions.AssetsFolder, "Metadata.json");
                return File.ReadAllText(fileName);
            });
        }

        public string GetStructureMetadata()
        {
            return _metadata.Value;
        }
    }
}