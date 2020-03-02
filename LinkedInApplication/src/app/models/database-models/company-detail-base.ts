import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class CompanyDetailBase {

//#region companyDetailId Prop
        @prop()
        companyDetailId : number;
//#endregion companyDetailId Prop


//#region companyId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        companyId : number;
//#endregion companyId Prop


//#region companyLogo Prop
        @maxLength({value:50})
        companyLogo : string;
//#endregion companyLogo Prop


//#region companyTagLine Prop
        @maxLength({value:100})
        companyTagLine : string;
//#endregion companyTagLine Prop


//#region companyAddress Prop
        @required()
        @maxLength({value:100})
        companyAddress : string;
//#endregion companyAddress Prop


//#region countryId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        countryId : number;
//#endregion countryId Prop


//#region stateId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        stateId : number;
//#endregion stateId Prop


//#region cityId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        cityId : number;
//#endregion cityId Prop


//#region foundDate Prop
        @prop()
        foundDate : Date;
//#endregion foundDate Prop


//#region overviewOfCompany Prop
        @prop()
        overviewOfCompany : string;
//#endregion overviewOfCompany Prop

}