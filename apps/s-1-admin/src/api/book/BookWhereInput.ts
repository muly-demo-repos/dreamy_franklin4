import { StringFilter } from "../../util/StringFilter";
import { StringNullableFilter } from "../../util/StringNullableFilter";

export type BookWhereInput = {
  id?: StringFilter;
  fld1?: StringNullableFilter;
};
