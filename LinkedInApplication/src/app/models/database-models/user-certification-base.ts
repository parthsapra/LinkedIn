import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class UserCertificationBase {

//#region userCertificationId Prop
        @prop()
        userCertificationId : number;
//#endregion userCertificationId Prop


//#region userId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userId : number;
//#endregion userId Prop


//#region certificateName Prop
        @required()
        @maxLength({value:50})
        certificateName : string;
//#endregion certificateName Prop


//#region issuingOrganizationName Prop
        @required()
        @maxLength({value:50})
        issuingOrganizationName : string;
//#endregion issuingOrganizationName Prop


//#region issueDate Prop
        @required()
        issueDate : Date;
//#endregion issueDate Prop


//#region expirationDate Prop
        @prop()
        expirationDate : Date;
//#endregion expirationDate Prop


//#region credentialId Prop
        @required()
        @maxLength({value:50})
        credentialId : string;
//#endregion credentialId Prop


//#region credentialURL Prop
        @maxLength({value:50})
        credentialURL : string;
//#endregion credentialURL Prop

}