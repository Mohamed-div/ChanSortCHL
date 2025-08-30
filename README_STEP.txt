📌 خطوات تشغيل دعم CHL في ChanSort على GitHub:

1. افتح مشروعك ChanSort (الـ Fork) على GitHub.
2. اضغط Add file → Upload files.
3. ارفع الملفات الموجودة في هذا الـ ZIP كما هي (ChlSerializer.cs + build.yml + README_STEP.txt).
   - الملف ChlSerializer.cs يروح داخل source/ChanSort.Loader/
   - الملف build.yml يروح داخل .github/workflows/
4. اعمل Commit changes.
5. افتح تبويب Actions في GitHub.
6. هيبدأ Workflow اسمه "Build ChanSort with CHL support".
7. استنى يخلص (2-3 دقائق).
8. بعد النجاح، هتلاقي Artifact اسمه ChanSort-CHL.zip.
9. نزّله وفك الضغط → هتلاقي ChanSort.exe الجاهز يفتح ملفات .chl.

✨ ملاحظات:
- ممكن تحتاج تضيف Newtonsoft.Json من NuGet لو مش موجود.
- وظيفة الحفظ Save لسه محتاجة تكميل (دلوقتي يفتح .chl ويعرض البيانات فقط).
