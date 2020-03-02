import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class HeadquartersBase {

//#region headquarterId Prop
        @prop()
        headquarterId : number;
//#endregion headquarterId Prop


//#region headquarterName Prop
        @required()
        @maxLength({value:50})
        headquarterName : string;
//#endregion headquarterName Prop


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


//#region companyId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        companyId : number;
//#endregion companyId Prop


//#region foundDate Prop
        @prop()
        foundDate : Date;
//#endregion foundDate Prop

}