import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class CompanyBase {

//#region companyId Prop
        @prop()
        companyId : number;
//#endregion companyId Prop


//#region companyName Prop
        @required()
        @maxLength({value:50})
        companyName : string;
//#endregion companyName Prop


//#region linkedInPublicURL Prop
        @required()
        @maxLength({value:50})
        linkedInPublicURL : string;
//#endregion linkedInPublicURL Prop


//#region companyWebsite Prop
        @required()
        @maxLength({value:50})
        companyWebsite : string;
//#endregion companyWebsite Prop


//#region companyIndustry Prop
        @required()
        @maxLength({value:50})
        companyIndustry : string;
//#endregion companyIndustry Prop


//#region companySize Prop
        @maxLength({value:50})
        companySize : string;
//#endregion companySize Prop


//#region companyType Prop
        @maxLength({value:50})
        companyType : string;
//#endregion companyType Prop

}