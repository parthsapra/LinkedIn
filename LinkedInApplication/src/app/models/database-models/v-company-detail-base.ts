import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class vCompanyDetailBase {

//#region companyName Prop
        @gridColumn({visible: true, columnIndex:1, allowSorting: true, headerKey: 'companyName', keyColumn: false})
        companyName : string;
//#endregion companyName Prop


//#region companyWebsite Prop
        @gridColumn({visible: true, columnIndex:2, allowSorting: true, headerKey: 'companyWebsite', keyColumn: false})
        companyWebsite : string;
//#endregion companyWebsite Prop


//#region companyIndustry Prop
        @gridColumn({visible: true, columnIndex:3, allowSorting: true, headerKey: 'companyIndustry', keyColumn: false})
        companyIndustry : string;
//#endregion companyIndustry Prop


//#region companySize Prop
        @gridColumn({visible: true, columnIndex:4, allowSorting: true, headerKey: 'companySize', keyColumn: false})
        companySize : string;
//#endregion companySize Prop


//#region companyType Prop
        @gridColumn({visible: true, columnIndex:5, allowSorting: true, headerKey: 'companyType', keyColumn: false})
        companyType : string;
//#endregion companyType Prop


//#region companyLogo Prop
        @gridColumn({visible: true, columnIndex:6, allowSorting: true, headerKey: 'companyLogo', keyColumn: false})
        companyLogo : string;
//#endregion companyLogo Prop


//#region companyTagLine Prop
        @gridColumn({visible: true, columnIndex:7, allowSorting: true, headerKey: 'companyTagLine', keyColumn: false})
        companyTagLine : string;
//#endregion companyTagLine Prop


//#region companyAddress Prop
        @gridColumn({visible: true, columnIndex:8, allowSorting: true, headerKey: 'companyAddress', keyColumn: false})
        companyAddress : string;
//#endregion companyAddress Prop


//#region foundDate Prop
        @gridColumn({visible: true, columnIndex:9, allowSorting: true, headerKey: 'foundDate', keyColumn: false})
        foundDate : any;
//#endregion foundDate Prop


//#region overviewOfCompany Prop
        @gridColumn({visible: true, columnIndex:10, allowSorting: true, headerKey: 'overviewOfCompany', keyColumn: false})
        overviewOfCompany : string;
//#endregion overviewOfCompany Prop


//#region specialityName Prop
        @gridColumn({visible: true, columnIndex:11, allowSorting: true, headerKey: 'specialityName', keyColumn: false})
        specialityName : string;
//#endregion specialityName Prop


//#region countryName Prop
        @gridColumn({visible: true, columnIndex:12, allowSorting: true, headerKey: 'countryName', keyColumn: false})
        countryName : string;
//#endregion countryName Prop


//#region headquarterName Prop
        @gridColumn({visible: true, columnIndex:13, allowSorting: true, headerKey: 'headquarterName', keyColumn: false})
        headquarterName : string;
//#endregion headquarterName Prop


//#region cityName Prop
        @gridColumn({visible: true, columnIndex:14, allowSorting: true, headerKey: 'cityName', keyColumn: false})
        cityName : string;
//#endregion cityName Prop


//#region stateName Prop
        @gridColumn({visible: true, columnIndex:15, allowSorting: true, headerKey: 'stateName', keyColumn: false})
        stateName : string;
//#endregion stateName Prop


//#region expr1 Prop
        @gridColumn({visible: true, columnIndex:16, allowSorting: true, headerKey: 'expr1', keyColumn: false})
        expr1 : string;
//#endregion expr1 Prop


//#region cityId Prop
        @gridColumn({visible: true, columnIndex:17, allowSorting: true, headerKey: 'cityId', keyColumn: true})
        cityId : number;
//#endregion cityId Prop

}