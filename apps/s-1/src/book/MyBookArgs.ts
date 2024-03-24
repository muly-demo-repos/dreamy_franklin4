import { ArgsType, Field } from "@nestjs/graphql";
import { MyBookInput } from "../user/MyBookInput";
import { ApiProperty } from "@nestjs/swagger";
import { Type } from "class-transformer";

@ArgsType()
class MyBookArgs {
    @Field(() => MyBookInput)
    @ApiProperty({
        required: true,
        type: () => MyBookInput
    })
    @Type(() => MyBookInput)
    data!: MyBookInput;

    @Field(() => String)
    @ApiProperty({
        required: true,
        type: () => String
    })
    @Type(() => String)
    queryString!: string;
}

export { MyBookArgs as MyBookArgs };