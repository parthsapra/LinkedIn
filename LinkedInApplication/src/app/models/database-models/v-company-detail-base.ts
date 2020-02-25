import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vCompanyDetailBase {

//#region cityName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'cityName', keyColumn: false})
        cityName : string;
//#endregion cityName Prop


//#region stateName Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'stateName', keyColumn: false})
        stateName : string;
//#endregion stateName Prop


//#region companyName Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'companyName', keyColumn: false})
        companyName : string;
//#endregion companyName Prop


//#region companyWebsite Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'companyWebsite', keyColumn: false})
        companyWebsite : string;
//#endregion companyWebsite Prop


//#region specialityName Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'specialityName', keyColumn: false})
        specialityName : string;
//#endregion specialityName Prop


//#region countryName Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'countryName', keyColumn: false})
        countryName : string;
//#endregion countryName Prop


//#region headquarterName Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'headquarterName', keyColumn: false})
        headquarterName : string;
//#endregion headquarterName Prop


//#region companyLogo Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'companyLogo', keyColumn: false})
        companyLogo : string;
//#endregion companyLogo Prop


//#region companyTagLine Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'companyTagLine', keyColumn: false})
        companyTagLine : string;
//#endregion companyTagLine Prop

}