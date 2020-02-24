import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class UserBase {

//#region userId Prop
        @prop()
        userId : number;
//#endregion userId Prop


//#region applicationLocaleId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        applicationLocaleId : number;
//#endregion applicationLocaleId Prop


//#region applicationTimeZoneId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        applicationTimeZoneId : number;
//#endregion applicationTimeZoneId Prop


//#region languageCode Prop
        @required()
        @maxLength({value:3})
        languageCode : string;
//#endregion languageCode Prop


//#region password Prop
        @required()
        @maxLength({value:132})
        password : any;
//#endregion password Prop


//#region salt Prop
        @required()
        @maxLength({value:140})
        salt : any;
//#endregion salt Prop


//#region loginBlocked Prop
        @required()
        loginBlocked : boolean;
//#endregion loginBlocked Prop


//#region statusId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        statusId : number;
//#endregion statusId Prop


//#region userEmail Prop
        @maxLength({value:200})
        userEmail : string;
//#endregion userEmail Prop


//#region userMobileNumber Prop
        @maxLength({value:10})
        userMobileNumber : string;
//#endregion userMobileNumber Prop


//#region userName Prop
        @required()
        @maxLength({value:50})
        userName : string;
//#endregion userName Prop


//#region userLastName Prop
        @maxLength({value:50})
        userLastName : string;
//#endregion userLastName Prop





}