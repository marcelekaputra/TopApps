﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TopApps.Models
{
    class Group : BindableBase
    {
        private string _groupId;
        private string _creatorId;
        private string _groupName;
        private string _groupDescription;
        private string _groupPhoto;

        public Group(string groupId, string groupName, string groupDescription, string groupPhoto)
        {
            this.GroupId = groupId;
            this.GroupName = groupName;
            this.GroupDescription = groupDescription;
            this.GroupPhoto = groupPhoto;
        }

        public  Group()
        { }

        public string GroupPhoto
        {
            get { return _groupPhoto; }
            set { SetProperty(ref this._groupPhoto, value); }
        }

        public string GroupDescription
        {
            get { return _groupDescription; }
            set { SetProperty(ref this._groupDescription, value); }
        }

        public string GroupName
        {
            get { return _groupName; }
            set { SetProperty(ref this._groupName, value); }
        }

        public string GroupId
        {
            get { return _groupId; }
            set { SetProperty(ref this._groupId, value); }
        }

        public string CreatorId
        {
            get { return _creatorId; }
            set { SetProperty(ref this._creatorId, value); }
        }
    }
}
