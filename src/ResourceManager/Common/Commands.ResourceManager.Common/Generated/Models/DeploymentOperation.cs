// 
// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//   http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.


namespace Microsoft.Azure.Management.Internal.Resources.Models
{
    /// <summary>
    /// Deployment operation information.
    /// </summary>
    public partial class DeploymentOperation
    {
        private string _id;

        /// <summary>
        /// Optional. Gets or sets full deployment operation id.
        /// </summary>
        public string Id
        {
            get { return this._id; }
            set { this._id = value; }
        }

        private string _operationId;

        /// <summary>
        /// Optional. Gets or sets deployment operation id.
        /// </summary>
        public string OperationId
        {
            get { return this._operationId; }
            set { this._operationId = value; }
        }

        private DeploymentOperationProperties _properties;

        /// <summary>
        /// Optional. Gets or sets deployment properties.
        /// </summary>
        public DeploymentOperationProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }

        /// <summary>
        /// Initializes a new instance of the DeploymentOperation class.
        /// </summary>
        public DeploymentOperation()
        {
        }
    }
}
