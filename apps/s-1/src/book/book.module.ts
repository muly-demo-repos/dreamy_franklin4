import { Module, forwardRef } from "@nestjs/common";
import { AuthModule } from "../auth/auth.module";
import { BookModuleBase } from "./base/book.module.base";
import { BookService } from "./book.service";
import { BookController } from "./book.controller";
import { BookResolver } from "./book.resolver";

@Module({
  imports: [BookModuleBase, forwardRef(() => AuthModule)],
  controllers: [BookController],
  providers: [BookService, BookResolver],
  exports: [BookService],
})
export class BookModule {}
