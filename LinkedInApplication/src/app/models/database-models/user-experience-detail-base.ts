import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class UserExperienceDetailBase {

//#region userExperienceDetailId Prop
        @prop()
        userExperienceDetailId : number;
//#endregion userExperienceDetailId Prop


//#region userId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userId : number;
//#endregion userId Prop


//#region industryName Prop
        @maxLength({value:50})
        industryName : string;
//#endregion industryName Prop


//#region designationId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        designationId : number;
//#endregion designationId Prop


//#region employmentType Prop
        @required()
        @maxLength({value:50})
        employmentType : string;
//#endregion employmentType Prop


//#region companyName Prop
        @required()
        @maxLength({value:50})
        companyName : string;
//#endregion companyName Prop


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


//#region startDate Prop
        @required()
        startDate : Date;
//#endregion startDate Prop


//#region endDate Prop
        @prop()
        endDate : Date;
//#endregion endDate Prop


//#region description Prop
        @prop()
        description : string;
//#endregion description Prop

}