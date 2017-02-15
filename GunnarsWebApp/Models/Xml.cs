
/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
[System.Xml.Serialization.XmlRootAttribute(Namespace = "", IsNullable = false)]
public partial class SubmissionCollection
{

    private SubmissionCollectionSubmissionModel[] submissionsField;

    /// <remarks/>
    [System.Xml.Serialization.XmlArrayItemAttribute("SubmissionModel", IsNullable = false)]
    public SubmissionCollectionSubmissionModel[] Submissions
    {
        get
        {
            return this.submissionsField;
        }
        set
        {
            this.submissionsField = value;
        }
    }
}

/// <remarks/>
[System.Xml.Serialization.XmlTypeAttribute(AnonymousType = true)]
public partial class SubmissionCollectionSubmissionModel
{

    private byte listIndexIDField;

    private System.DateTime submissionDateField;

    private string projectTypeField;

    private string nameField;

    private string emailField;

    private string addressField;

    private string postalCodeField;

    private string cityField;

    private string phoneNumberField;

    private string projectNameField;

    private string projectDescriptionField;

    private string projectWebSiteURLField;

    private string projectFilePathField;

    private string projectFileNameField;

    /// <remarks/>
    public byte ListIndexID
    {
        get
        {
            return this.listIndexIDField;
        }
        set
        {
            this.listIndexIDField = value;
        }
    }

    /// <remarks/>
    public System.DateTime SubmissionDate
    {
        get
        {
            return this.submissionDateField;
        }
        set
        {
            this.submissionDateField = value;
        }
    }

    /// <remarks/>
    public string ProjectType
    {
        get
        {
            return this.projectTypeField;
        }
        set
        {
            this.projectTypeField = value;
        }
    }

    /// <remarks/>
    public string Name
    {
        get
        {
            return this.nameField;
        }
        set
        {
            this.nameField = value;
        }
    }

    /// <remarks/>
    public string Email
    {
        get
        {
            return this.emailField;
        }
        set
        {
            this.emailField = value;
        }
    }

    /// <remarks/>
    public string Address
    {
        get
        {
            return this.addressField;
        }
        set
        {
            this.addressField = value;
        }
    }

    /// <remarks/>
    public string PostalCode
    {
        get
        {
            return this.postalCodeField;
        }
        set
        {
            this.postalCodeField = value;
        }
    }

    /// <remarks/>
    public string City
    {
        get
        {
            return this.cityField;
        }
        set
        {
            this.cityField = value;
        }
    }

    /// <remarks/>
    public string PhoneNumber
    {
        get
        {
            return this.phoneNumberField;
        }
        set
        {
            this.phoneNumberField = value;
        }
    }

    /// <remarks/>
    public string ProjectName
    {
        get
        {
            return this.projectNameField;
        }
        set
        {
            this.projectNameField = value;
        }
    }

    /// <remarks/>
    public string ProjectDescription
    {
        get
        {
            return this.projectDescriptionField;
        }
        set
        {
            this.projectDescriptionField = value;
        }
    }

    /// <remarks/>
    public string ProjectWebSiteURL
    {
        get
        {
            return this.projectWebSiteURLField;
        }
        set
        {
            this.projectWebSiteURLField = value;
        }
    }

    /// <remarks/>
    public string ProjectFilePath
    {
        get
        {
            return this.projectFilePathField;
        }
        set
        {
            this.projectFilePathField = value;
        }
    }

    /// <remarks/>
    public string ProjectFileName
    {
        get
        {
            return this.projectFileNameField;
        }
        set
        {
            this.projectFileNameField = value;
        }
    }
}

