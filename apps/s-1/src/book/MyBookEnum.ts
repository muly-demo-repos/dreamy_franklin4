import { registerEnumType } from "@nestjs/graphql";

export enum MyBookEnum {
    GoodBook = "goodBook",
    NiceBook = "niceBook",
    MehBook = "mehBook"
}

registerEnumType(MyBookEnum, {
    name: "MyBookEnum",
  });