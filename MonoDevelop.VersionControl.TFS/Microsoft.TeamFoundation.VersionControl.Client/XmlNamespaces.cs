//
// XmlNamespaces.cs
//
// Author:
//       Ventsislav Mladenov <vmladenov.mladenov@gmail.com>
//
// Copyright (c) 2013 Ventsislav Mladenov
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to deal
// in the Software without restriction, including without limitation the rights
// to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
// copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
// OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN
// THE SOFTWARE.
using System.Xml.Linq;
using System.Xml;

namespace Microsoft.TeamFoundation.VersionControl.Client
{
    public static class XmlNamespaces
    {
        private const string MessageNsUrl = "http://schemas.microsoft.com/TeamFoundation/2005/06/VersionControl/ClientServices/03";
        public static readonly XNamespace MessageNs = MessageNsUrl;

        public static XName GetMessageElementName(string elementName)
        {
            return MessageNs + elementName;
        }

        public static IXmlNamespaceResolver NsResolver
        {
            get
            {
                XmlNamespaceManager manager = new XmlNamespaceManager(new NameTable());
                manager.AddNamespace("msg", XmlNamespaces.MessageNs.ToString());
                return manager;
            }
        }
    }
}

