import { prop,propObject,propArray,required,maxLength,range  } from "@rxweb/reactive-form-validators"
import { gridColumn } from "@rxweb/grid"


export class PostBase {

//#region postId Prop
        @prop()
        postId : number;
//#endregion postId Prop


//#region postText Prop
        @maxLength({value:50})
        postText : string;
//#endregion postText Prop


//#region postMediaTypeId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        postMediaTypeId : number;
//#endregion postMediaTypeId Prop


//#region postMediaURL Prop
        @prop()
        postMediaURL : string;
//#endregion postMediaURL Prop


//#region userId Prop
        @range({minimumNumber:1,maximumNumber:2147483647})
        @required()
        userId : number;
//#endregion userId Prop


//#region postCreationDateTime Prop
        @required()
        postCreationDateTime : any;
//#endregion postCreationDateTime Prop


//#region postUpdateDateTime Prop
        @prop()
        postUpdateDateTime : any;
//#endregion postUpdateDateTime Prop

}