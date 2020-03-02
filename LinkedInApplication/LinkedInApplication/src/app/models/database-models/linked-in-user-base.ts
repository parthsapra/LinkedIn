import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class LinkedInUserBase {

//#region lIUserId Prop
        @prop()
        lIUserId : number;
//#endregion lIUserId Prop


//#region lIFirstName Prop
        @required()
        @maxLength({value:50})
        lIFirstName : string;
//#endregion lIFirstName Prop


//#region lILastName Prop
        @required()
        @maxLength({value:50})
        lILastName : string;
//#endregion lILastName Prop


//#region lIRegistrationDate Prop
        @prop()
        lIRegistrationDate : Date;
//#endregion lIRegistrationDate Prop


//#region lIEmailId Prop
        @maxLength({value:50})
        lIEmailId : string;
//#endregion lIEmailId Prop


//#region lIMobileNumber Prop
        @maxLength({value:12})
        lIMobileNumber : string;
//#endregion lIMobileNumber Prop


//#region isActive Prop
        @prop()
        isActive : boolean;
//#endregion isActive Prop


//#region lIPassword Prop
        @maxLength({value:132})
        lIPassword : any;
//#endregion lIPassword Prop


//#region lISalt Prop
        @maxLength({value:140})
        lISalt : any;
//#endregion lISalt Prop















}