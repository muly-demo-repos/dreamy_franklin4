import { Book as TBook } from "../api/book/Book";

export const BOOK_TITLE_FIELD = "fld1";

export const BookTitle = (record: TBook): string => {
  return record.fld1?.toString() || String(record.id);
};
