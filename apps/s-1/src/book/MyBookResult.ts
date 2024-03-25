import { ObjectType, Field } from "@nestjs/graphql";
import { ApiProperty } from "@nestjs/swagger";
import { Type } from "class-transformer";
import { MyBookEnum } from "./MyBookEnum";

@ObjectType("MyBookResultObject")
class MyBookResult {
    @Field(() => Number)
    @ApiProperty({
        required: true,
        type: () => Number
    })
    @Type(() => Number)
    bookId!: number;

    @Field(() => MyBookEnum)
    @ApiProperty({
        required: true,
        enum: MyBookEnum
    })
    bookType!: "goodBook" | "niceBook" | "mehBook";

    @Field(() => String)
    @ApiProperty({
        required: true,
        type: () => String
    })
    @Type(() => String)
    reponse!: string;
}

export { MyBookResult as MyBookResult };